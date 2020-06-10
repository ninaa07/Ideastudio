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
  idejnaResenja: IdejnoResenje[];
  lokacijskaDozvola: LokacijskaDozvola;
  informacijeOLokaciji: InformacijeOLokaciji;
  idejnoResenje: IdejnoResenje;
  selectedIol = 'Informacije o lokaciji';
  selectedIr = 'Idejno resenje';
  datumIzdavanja: string;
  disabled: boolean;

  constructor(private lokacijskaDozvolaService: LokacijskaDozvolaService,
    private objekatService: ObjekatService,
    private dialogRef: MatDialogRef<LokacijskaDozvolaDialog>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private datePipe: DatePipe,
    private alert: AlertService) {
    this.disabled = false;
  }

  ngOnInit(): void {
    this.informacijeOLokacijiList = this.data.informacijeOLokaciji;
    this.idejnaResenja = this.data.idejnaResenja;
    this.lokacijskaDozvola = this.data.lokacijskaDozvola ? this.data.lokacijskaDozvola : new LokacijskaDozvola();

    if (this.data.action === 'view') {
      this.disabled = true;
    }

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
    this.validate();

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
    this.idejnoResenje = ir;
    this.lokacijskaDozvola.nazivIdejnogResenja = newIr;
  }

  validate() {
    let objekat = null;
    debugger;
    this.objekatService.getById(this.idejnoResenje.objekatId).subscribe(result => {
      objekat = result;
    }, error => {
      return false;
    });

    if (this.lokacijskaDozvola.nazivObjekta.toLowerCase() !== objekat.naziv.toLowerCase()
      || this.lokacijskaDozvola.brojParcele !== objekat.brojParcele) {
      return false;
    }

    return true;
  }

  close() {
    this.dialogRef.close(false);
  }

}
