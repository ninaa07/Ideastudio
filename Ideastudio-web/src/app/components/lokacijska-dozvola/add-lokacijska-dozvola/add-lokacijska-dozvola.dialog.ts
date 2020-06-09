import { Component, OnInit, Inject } from '@angular/core';
import { LokacijskaDozvolaService } from 'src/app/services/lokacijska-dozvola.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AlertService } from 'src/app/services/alert.service';
import { InformacijeOLokaciji } from 'src/app/models/informacije-o-lokaciji.model';
import { IdejnoResenje } from 'src/app/models/idejno-resenje.model';

@Component({
  selector: 'add-lokacijska-dozvola',
  templateUrl: './add-lokacijska-dozvola.dialog.html',
  styleUrls: ['./add-lokacijska-dozvola.dialog.scss']
})
export class AddLokacijskaDozvolaDialog implements OnInit {

  informacijeOLokaciji: InformacijeOLokaciji[];
  idejnaResenja: IdejnoResenje[];
  selectedIol = 'Informacije o lokaciji';
  selectedIr = 'Idejno resenje';

  constructor(private lokacijskaDozvolaService: LokacijskaDozvolaService,
    private dialogRef: MatDialogRef<AddLokacijskaDozvolaDialog>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private alert: AlertService) { }

  ngOnInit(): void {
    this.informacijeOLokaciji = this.data.informacijeOLokaciji;
    this.idejnaResenja = this.data.idejnaResenja;
  }

  changeSelectionIol(newIol: string) {
    this.selectedIol = newIol;
  }

  changeSelectionIr(newIr: string) {
    this.selectedIr = newIr;
  }

  close() {
    this.dialogRef.close(false);
  }

}
