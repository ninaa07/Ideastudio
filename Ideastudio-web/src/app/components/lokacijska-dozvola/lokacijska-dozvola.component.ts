import { Component, OnInit } from '@angular/core';
import { LokacijskaDozvola } from 'src/app/models/lokacijska-dozvola.model';
import { LokacijskaDozvolaService } from 'src/app/services/lokacijska-dozvola.service';
import { MatDialog } from '@angular/material/dialog';
import { ConfirmDialog } from '../confirm/confirm.dialog';
import { InformacijeOLokacijiService } from 'src/app/services/informacije-o-lokaciji.service';
import { InformacijeOLokaciji } from 'src/app/models/informacije-o-lokaciji.model';
import { AddLokacijskaDozvolaDialog } from './add-lokacijska-dozvola/add-lokacijska-dozvola.dialog';
import { EditLokacijskaDozvolaDialog } from './edit-lokacijska-dozvola/edit-lokacijska-dozvola.dialog.';
import { IdejnoResenje } from 'src/app/models/idejno-resenje.model';
import { IdejnoResenjeService } from 'src/app/services/idejno-resenje.service';

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
    private dialog: MatDialog
  ) {
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

  ngOnInit() {
    this.getAll();
  }

  getAll(): void {
    this.lokacijskaDozvolaService.getAll().subscribe(result => {
      this.lokacijskeDozvole = result;
    }, error => {
      console.log('Greska!', error);
    });
  }

  getById(id: number): LokacijskaDozvola {

    this.lokacijskaDozvolaService.getById(id).subscribe(result => {
      this.lokacijskaDozvola = result;
    }, error => {
      console.log('Greska!', error);
    });

    return this.lokacijskaDozvola;
  }

  add(): void {

    const dialogRef = this.dialog.open(AddLokacijskaDozvolaDialog, {
      width: '700px',
      data: { informacijeOLokaciji: this.informacijeOLokaciji, idejnaResenja: this.idejnaResenja },
      autoFocus: true,
      disableClose: true
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.lokacijskeDozvole.push(result);
      }
    });
  }

  edit(lokacijskaDozvola: LokacijskaDozvola): void {

    const dialogRef = this.dialog.open(EditLokacijskaDozvolaDialog, {
      width: '500px',
      autoFocus: true,
      data: { lokacijskaDozvola },
      disableClose: true
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        const item = this.lokacijskeDozvole.find(x => x.id === result.id);
        this.lokacijskeDozvole.splice(this.lokacijskeDozvole.indexOf(item), 1, result);
      }
    });
  }

  delete(id: number): void {

    const confirmDialog = this.dialog.open(ConfirmDialog, {
      disableClose: true,
      autoFocus: true
    });

    confirmDialog.afterClosed().subscribe(response => {
      if (response) {
        this.lokacijskaDozvolaService.delete(id).subscribe(result => {
          if (result) {
            const item = this.lokacijskeDozvole.find(x => x.id === result.resultObject.id);
            this.lokacijskeDozvole.splice(this.lokacijskeDozvole.indexOf(item), 1);
          }
        })
      }
    });
  }
}
