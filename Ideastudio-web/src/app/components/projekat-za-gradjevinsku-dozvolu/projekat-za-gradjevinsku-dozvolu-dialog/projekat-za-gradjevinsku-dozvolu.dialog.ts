import { Component, OnInit, Inject, ChangeDetectorRef } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { AlertService } from 'src/app/services/alert.service';
import { ProjekatZaGradjevinskuDozvoluService } from 'src/app/services/projekat-za-gradjevinsku-dozvolu.service';
import { DatePipe } from '@angular/common';
import { ProjekatZaGradjevinskuDozvolu, STATUSIDOKUMENTA } from 'src/app/models/projekat-za-gradjevinsku-dozvolu.model';
import { StatusDokumentaPipe } from 'src/app/pipes/status-dokumenta.pipe';
import { IdejnoResenje } from 'src/app/models/idejno-resenje.model';
import { IdejnoResenjeService } from 'src/app/services/idejno-resenje.service';
import { GlavniProjektantService } from 'src/app/services/glavni-projektant.service';
import { MatTableDataSource } from '@angular/material/table';
import { Povrsina, Status } from 'src/app/models/povrsina.model';
import { VrstaPovrsine } from 'src/app/models/vrsta-povrsine.model';
import { Prostorija } from 'src/app/models/prostorija.model';

@Component({
  selector: 'projekat-za-gradjevinsku-dozvolu-dialog',
  templateUrl: './projekat-za-gradjevinsku-dozvolu.dialog.html',
  styleUrls: ['./projekat-za-gradjevinsku-dozvolu.dialog.scss']
})
export class ProjekatZaGradjevinskuDozvoluDialog implements OnInit {

  pgd: ProjekatZaGradjevinskuDozvolu;
  datumIzrade: Date;
  statusi = STATUSIDOKUMENTA;
  status = 'Status dokumenta';
  nazivProjektanta: string;
  idejnaResenja: IdejnoResenje[];
  vrstePovrsina: VrstaPovrsine[];
  selectedIr = 'Idejno resenje';

  dataSource: MatTableDataSource<Povrsina>;
  displayedColumns: string[] = ['Oznaka', 'VrstaPoda', 'VrstaPovrsine', 'Prostorija', 'Izmeni', 'Obrisi'];

  constructor(private projekatZaGradjevinskuDozvoluService: ProjekatZaGradjevinskuDozvoluService,
    private dialogRef: MatDialogRef<ProjekatZaGradjevinskuDozvoluDialog>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private statusDokumentaPipe: StatusDokumentaPipe,
    private alert: AlertService,
    private glavniProjektantService: GlavniProjektantService,
    private changeDetectorRefs: ChangeDetectorRef
  ) {
    this.dataSource = new MatTableDataSource<Povrsina>();
  }

  ngOnInit(): void {
    this.pgd = this.data.projekatZaGD ? this.data.projekatZaGD : new ProjekatZaGradjevinskuDozvolu();
    this.idejnaResenja = this.data.idejnaResenja;
    this.vrstePovrsina = this.data.vrstePovrsina;

    if (this.data.action === 'view' || this.data.action === 'edit') {
      this.dataSource.data = this.pgd.povrsine;

      this.datumIzrade = this.pgd.datumIzrade;

      this.pgd.povrsine.forEach(element => {
        element.isEditable = false;
      });

      if (this.pgd.nazivIdejnogResenja !== null) {
        this.selectedIr = this.pgd.nazivIdejnogResenja;
      }
    } else {
      this.datumIzrade = new Date();
    }
  }

  save() {
    if (!this.validate()) {
      return;
    }

    if (!this.pgd.id) {

      this.pgd.nazivIdejnogResenja = this.selectedIr;

      this.projekatZaGradjevinskuDozvoluService.add(this.pgd).subscribe(result => {
        if (result.success) {
          this.alert.showSuccess(result.message, 'Success');
          this.dialogRef.close(result.resultObject);
        }
      }, error => {
        this.alert.errorHandler(error);
      });
    } else {
      this.projekatZaGradjevinskuDozvoluService.update(this.pgd, this.pgd.id).subscribe(result => {
        if (result.success) {
          this.alert.showSuccess(result.message, 'Success');
          this.dialogRef.close(result.resultObject);
        }
      }, error => {
        this.alert.errorHandler(error);
      });
    }
  }

  changeSelection(id: number) {
    this.pgd.statusDokumenta = id;
    this.status = this.statusDokumentaPipe.transform(id);
  }

  changeSelectionIr(ir: IdejnoResenje) {
    this.pgd.idejnoResenjeId = ir.id;
    this.selectedIr = ir.naziv;

    this.glavniProjektantService.getById(ir.glavniProjektantId).subscribe(result => {
      if (result) {
        this.nazivProjektanta = result.imePrezime;
      }
    });
  }

  changeSelectionVp(vp: VrstaPovrsine, p: Povrsina) {
    p.vrstaPovrsine = vp;
  }

  changeSelectionP(pr: Prostorija, p: Povrsina) {
    p.prostorijaNaziv = pr.naziv;
  }

  add() {
    const p = new Povrsina();
    p.isEditable = true;
    //p.status = Status.Insert;
    this.pgd.povrsine.push(p);
    this.dataSource.data = this.pgd.povrsine;
  }

  edit(p: Povrsina) {
    //p.status = Status.Update;
    p.isEditable = true;
  }

  delete(p: Povrsina) {
    p.status = Status.Delete;
    this.dataSource.data.splice(this.dataSource.data.indexOf(p), 1);
    this.changeDetectorRefs.detectChanges();
  }

  saveElement(p: Povrsina) {
    p.isEditable = false;

    if (p.id === undefined) {
      p.status = Status.Insert;
    }
    else {
      p.status = Status.Update;
    }

    console.log(p);
  }

  validate() {
    if (!this.pgd.naziv) {
      this.alert.showError('Neispravno uneti podaci', 'Error');
      return false;
    }

    return true;
  }

  close() {
    this.dialogRef.close(false);
  }
}