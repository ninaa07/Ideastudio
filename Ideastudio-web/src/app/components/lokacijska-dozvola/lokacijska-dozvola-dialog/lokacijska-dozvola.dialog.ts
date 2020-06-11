import { Component, OnInit, Inject } from '@angular/core';
import { LokacijskaDozvolaService } from 'src/app/services/lokacijska-dozvola.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AlertService } from 'src/app/services/alert.service';
import { InformacijeOLokaciji } from 'src/app/models/informacije-o-lokaciji.model';
import { IdejnoResenje } from 'src/app/models/idejno-resenje.model';
import { LokacijskaDozvola } from 'src/app/models/lokacijska-dozvola.model';
import { DatePipe } from '@angular/common';
import { ObjekatService } from 'src/app/services/objekat.service';

@Component({
  selector: 'lokacijska-dozvola-dialog',
  templateUrl: './lokacijska-dozvola.dialog.html',
  styleUrls: ['./lokacijska-dozvola.dialog.scss']
})
export class LokacijskaDozvolaDialog implements OnInit {

  informacijeOLokacijiList: InformacijeOLokaciji[];
  lokacijskaDozvola: LokacijskaDozvola;
  informacijeOLokaciji: InformacijeOLokaciji;
  selectedIol = 'Informacije o lokaciji';
  selectedIr = 'Idejno resenje';
  datumIzdavanja: string;
  nazivObjekta: string;

  constructor(private lokacijskaDozvolaService: LokacijskaDozvolaService,
    private dialogRef: MatDialogRef<LokacijskaDozvolaDialog>,
    private objekatService: ObjekatService,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private datePipe: DatePipe,
    private alert: AlertService) { }

  ngOnInit(): void {
    this.informacijeOLokacijiList = this.data.informacijeOLokaciji;
    this.lokacijskaDozvola = this.data.lokacijskaDozvola ? this.data.lokacijskaDozvola : new LokacijskaDozvola();

    if (this.data.action === 'view' || this.data.action === 'edit') {
      this.informacijeOLokaciji = this.informacijeOLokacijiList.find(x => x.id === this.lokacijskaDozvola.informacijeOLokacijiId);
      this.selectedIol = this.informacijeOLokaciji.naziv;
      this.datumIzdavanja = this.datePipe.transform(this.lokacijskaDozvola.datumIzdavanja, 'dd/MM/yyyy');

      if (this.lokacijskaDozvola.nazivIdejnogResenja !== null) {
        this.selectedIr = this.lokacijskaDozvola.nazivIdejnogResenja;
      }
    } else {
      this.datumIzdavanja = this.datePipe.transform(new Date(), 'dd/MM/yyyy');
      this.informacijeOLokaciji = new InformacijeOLokaciji();
    }
  }

  save() {
    if (!this.validate()) {
      return;
    }

    if (!this.lokacijskaDozvola.id) {
      this.lokacijskaDozvolaService.add(this.lokacijskaDozvola).subscribe(result => {
        if (result.success) {
          this.alert.showSuccess(result.message, 'Success');
          this.dialogRef.close(result.resultObject);
        }
      }, error => {
        this.alert.errorHandler(error);
      });
    } else {
      this.lokacijskaDozvolaService.update(this.lokacijskaDozvola, this.lokacijskaDozvola.id).subscribe(result => {
        if (result.success) {
          this.alert.showSuccess(result.message, 'Success');
          this.dialogRef.close(result.resultObject);
        }
      }, error => {
        this.alert.errorHandler(error);
      });
    }
  }

  changeSelectionIol(iol: InformacijeOLokaciji, newIol: string) {
    this.selectedIol = newIol;
    this.informacijeOLokaciji = iol;
    this.lokacijskaDozvola.informacijeOLokacijiId = iol.id;
  }

  changeSelectionIr(ir: IdejnoResenje, newIr: string) {
    this.selectedIr = newIr;
    this.lokacijskaDozvola.nazivIdejnogResenja = newIr;

    this.objekatService.getById(ir.objekatId).subscribe(result => {
      if (result) {
        this.nazivObjekta = result.naziv;
      }
    });
  }

  validate() {
    if (!this.lokacijskaDozvola.naziv ||
      !this.lokacijskaDozvola.opstiPodaci ||
      !this.lokacijskaDozvola.lokacijskiUslovi ||
      !this.lokacijskaDozvola.brojParcele ||
      !this.lokacijskaDozvola.povrsinaParcele) {
      this.alert.showError('Neispravno uneti podaci', 'Error');
      return false;
    }

    return true;
  }

  close() {
    this.dialogRef.close(false);
  }
}
