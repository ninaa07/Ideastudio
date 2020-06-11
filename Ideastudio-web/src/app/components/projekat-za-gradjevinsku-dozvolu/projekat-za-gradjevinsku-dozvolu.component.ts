import { Component, OnInit } from '@angular/core';
import { ProjekatZaGradjevinskuDozvolu } from 'src/app/models/projekat-za-gradjevinsku-dozvolu.model';
import { ProjekatZaGradjevinskuDozvoluService } from 'src/app/services/projekat-za-gradjevinsku-dozvolu.service';
import { MatDialog } from '@angular/material/dialog';
import { AlertService } from 'src/app/services/alert.service';
import { ConfirmDialog } from '../confirm/confirm.dialog';
import { ProjekatZaGradjevinskuDozvoluDialog } from './projekat-za-gradjevinsku-dozvolu-dialog/projekat-za-gradjevinsku-dozvolu.dialog';
import { NgbDropdownConfig } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'projekat-za-gradjevinsku-dozvolu',
  templateUrl: './projekat-za-gradjevinsku-dozvolu.component.html',
  styleUrls: ['./projekat-za-gradjevinsku-dozvolu.component.scss']
})
export class ProjekatZaGradjevinskuDozvoluComponent implements OnInit {

  projektiZaGD: ProjekatZaGradjevinskuDozvolu[];

  constructor(
    private projekatZaGDService: ProjekatZaGradjevinskuDozvoluService,
    private dialog: MatDialog,
    private config: NgbDropdownConfig,
    private alert: AlertService
  ) { }

  ngOnInit() {
    this.getAll();
  }

  getAll(): void {
    this.projekatZaGDService.getAll().subscribe(result => {
      this.projektiZaGD = result;
    }, error => {
      this.alert.errorHandler(error);
    });
  }

  open(id: number): void {
    this.projekatZaGDService.getById(id).subscribe(result => {

      const dialogRef = this.dialog.open(ProjekatZaGradjevinskuDozvoluDialog, {
        width: '700px',
        data: { projekatZaGD: result, action: 'view' },
        autoFocus: true,
        disableClose: true
      });

    }, error => {
      this.alert.errorHandler(error);
    });
  }

  add(): void {
    const dialogRef = this.dialog.open(ProjekatZaGradjevinskuDozvoluDialog, {
      width: '700px',
      data: { action: 'add' },
      autoFocus: true,
      disableClose: true
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.projektiZaGD.push(result);
      }
    });
  }

  edit(pgd: ProjekatZaGradjevinskuDozvolu): void {

    const dialogRef = this.dialog.open(ProjekatZaGradjevinskuDozvoluDialog, {
      width: '700px',
      autoFocus: true,
      data: { projekatZaGD: pgd, action: 'edit' },
      disableClose: true
    });
  }

  delete(id: number): void {

    const confirmDialog = this.dialog.open(ConfirmDialog, {
      disableClose: true,
      autoFocus: true,
      data: { title: 'projekat za građevinsku dozvolu' }
    });

    confirmDialog.afterClosed().subscribe(response => {
      if (response) {
        this.projekatZaGDService.delete(id).subscribe(result => {
          if (result) {
            this.alert.showSuccess(result.message, 'Success');
            const item = this.projektiZaGD.find(x => x.id === result.resultObject.id);
            this.projektiZaGD.splice(this.projektiZaGD.indexOf(item), 1);
          }
        }, error => {
          this.alert.errorHandler(error);
        });
      }
    });
  }

}
