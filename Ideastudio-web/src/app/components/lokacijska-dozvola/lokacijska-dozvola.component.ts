import { Component, OnInit } from '@angular/core';
import { LokacijskaDozvola } from 'src/app/models/lokacijska-dozvola.model';
import { LokacijskaDozvolaService } from 'src/app/services/lokacijska-dozvola.service';
import { MatDialog } from '@angular/material/dialog';
import { ConfirmDialog } from '../confirm/confirm.dialog';
import { InformacijeOLokacijiService } from 'src/app/services/informacije-o-lokaciji.service';
import { InformacijeOLokaciji } from 'src/app/models/informacije-o-lokaciji.model';
import { IdejnoResenje } from 'src/app/models/idejno-resenje.model';
import { IdejnoResenjeService } from 'src/app/services/idejno-resenje.service';
import { LokacijskaDozvolaDialog } from './lokacijska-dozvola-dialog/lokacijska-dozvola.dialog';
import { AlertService } from 'src/app/services/alert.service';

@Component({
  selector: 'lokacijska-dozvola',
  templateUrl: './lokacijska-dozvola.component.html',
  styleUrls: ['./lokacijska-dozvola.component.scss']
})
export class LokacijskaDozvolaComponent implements OnInit {

  lokacijskeDozvole: LokacijskaDozvola[];
  lokacijskaDozvola: LokacijskaDozvola;
  informacijeOLokaciji: InformacijeOLokaciji[];
  idejnaResenja: IdejnoResenje[];

  constructor(
    private lokacijskaDozvolaService: LokacijskaDozvolaService,
    private informacijeOLokacijiService: InformacijeOLokacijiService,
    private idejnoResenjeService: IdejnoResenjeService,
    private dialog: MatDialog,
    private alert: AlertService
  ) { }

  ngOnInit() {
    this.getAll();

    this.informacijeOLokacijiService.getAll().subscribe(result => {
      this.informacijeOLokaciji = result;
    }, error => {
      console.log('Greska!', error);
    });

    this.idejnoResenjeService.getAll().subscribe(result => {
      this.idejnaResenja = result;
    }, error => {
      console.log('Greska!', error);
    });
  }

  getAll(): void {
    this.lokacijskaDozvolaService.getAll().subscribe(result => {
      this.lokacijskeDozvole = result;
    }, error => {
      console.log('Greska!', error);
    });
  }

  open(id: number): void {
    this.lokacijskaDozvolaService.getById(id).subscribe(result => {

      const dialogRef = this.dialog.open(LokacijskaDozvolaDialog, {
        width: '700px',
        data: { informacijeOLokaciji: this.informacijeOLokaciji, idejnaResenja: this.idejnaResenja, lokacijskaDozvola: result, action: 'view' },
        autoFocus: true,
        disableClose: true
      });

      this.lokacijskaDozvola = result;
    }, error => {
      console.log('Greska!', error);
    });
  }

  add(): void {
    const dialogRef = this.dialog.open(LokacijskaDozvolaDialog, {
      width: '700px',
      data: { informacijeOLokaciji: this.informacijeOLokaciji, idejnaResenja: this.idejnaResenja, action: 'add' },
      autoFocus: true,
      disableClose: true
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.lokacijskeDozvole.push(result);
      }
    });
  }

  edit(ld: LokacijskaDozvola): void {

    const dialogRef = this.dialog.open(LokacijskaDozvolaDialog, {
      width: '700px',
      autoFocus: true,
      data: { informacijeOLokaciji: this.informacijeOLokaciji, idejnaResenja: this.idejnaResenja, lokacijskaDozvola: ld, action: 'edit' },
      disableClose: true
    });
  }

  delete(id: number): void {

    const confirmDialog = this.dialog.open(ConfirmDialog, {
      disableClose: true,
      autoFocus: true,
      data: { title: 'lokacijsku dozvolu' }
    });

    confirmDialog.afterClosed().subscribe(response => {
      if (response) {
        this.lokacijskaDozvolaService.delete(id).subscribe(result => {
          if (result) {
            this.alert.showSuccess(result.message, 'Success');
            const item = this.lokacijskeDozvole.find(x => x.id === result.resultObject.id);
            this.lokacijskeDozvole.splice(this.lokacijskeDozvole.indexOf(item), 1);
          }
        }, error => {
          this.alert.errorHandler(error);
        });
      }
    });
  }
}
