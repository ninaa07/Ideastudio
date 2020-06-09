import { Component, OnInit, Inject } from '@angular/core';
import { LokacijskaDozvolaService } from 'src/app/services/lokacijska-dozvola.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AlertService } from 'src/app/services/alert.service';
import { InformacijeOLokaciji } from 'src/app/models/informacije-o-lokaciji.model';
import { IdejnoResenje } from 'src/app/models/idejno-resenje.model';
import { LokacijskaDozvola } from 'src/app/models/lokacijska-dozvola.model';
import { DatePipe } from '@angular/common';
import { ObjekatService } from 'src/app/services/objekat.service';
import { Objekat } from 'src/app/models/objekat.model';

@Component({
  selector: 'add-lokacijska-dozvola',
  templateUrl: './add-lokacijska-dozvola.dialog.html',
  styleUrls: ['./add-lokacijska-dozvola.dialog.scss']
})
export class AddLokacijskaDozvolaDialog implements OnInit {

  informacijeOLokaciji: InformacijeOLokaciji[];
  idejnaResenja: IdejnoResenje[];
  lokacijskaDozvola: LokacijskaDozvola;
  idejnoResenje: IdejnoResenje;
  selectedIol = 'Informacije o lokaciji';
  selectedIr = 'Idejno resenje';

  constructor(private lokacijskaDozvolaService: LokacijskaDozvolaService,
    private objekatService: ObjekatService,
    private dialogRef: MatDialogRef<AddLokacijskaDozvolaDialog>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private datePipe: DatePipe,
    private alert: AlertService) { }

  ngOnInit(): void {
    this.informacijeOLokaciji = this.data.informacijeOLokaciji;
    this.idejnaResenja = this.data.idejnaResenja;
    this.lokacijskaDozvola = this.data.lokacijskaDozvola ? this.data.lokacijskaDozvola : new LokacijskaDozvola();
    if (!this.lokacijskaDozvola.datumIzdavanja) {
      this.lokacijskaDozvola.datumIzdavanja = new Date();
      this.datePipe.transform(this.lokacijskaDozvola.datumIzdavanja, 'dd/MM/yyyy');
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

  changeSelectionIol(id: number, newIol: string) {
    this.selectedIol = newIol;
    this.lokacijskaDozvola.informacijeOLokacijiId = id;
  }

  changeSelectionIr(idejnoResenje: IdejnoResenje, newIr: string) {
    this.selectedIr = newIr;
    this.idejnoResenje = idejnoResenje;
  }

  validate() {
    // let objekat = null;

    // this.objekatService.getById(this.idejnoResenje.objekatId).subscribe(result => {
    //   objekat = result;
    // }, error => {
    //   return false;
    // });

    // if (this.lokacijskaDozvola.nazivObjekta.toLowerCase() !== objekat.naziv.toLowerCase() || this.lokacijskaDozvola.brojParcele !== objekat.brojParcele) {
    //   return false;
    // }

    return true;
  }

  close() {
    this.dialogRef.close(false);
  }

}
