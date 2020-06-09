import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { CommonModule } from '@angular/common';
import { ThemeModule } from './theme/theme.module';
import { AppRoutingModule } from './app-routing.module';
import { MatDialogModule } from '@angular/material/dialog';
import { DashboardPage } from './pages/dashboard/dashboard.page';
import { PregledPage } from './pages/pregled/pregled.page';
import { LokacijskaDozvolaComponent } from './components/lokacijska-dozvola/lokacijska-dozvola/lokacijska-dozvola.component';
import { ConfirmDialog } from './components/confirm/confirm.dialog';
import { EditLokacijskaDozvolaDialog } from './components/lokacijska-dozvola/edit-lokacijska-dozvola/edit-lokacijska-dozvola.dialog.';
import { AddLokacijskaDozvolaDialog } from './components/lokacijska-dozvola/add-lokacijska-dozvola/add-lokacijska-dozvola.dialog';

@NgModule({
  imports: [
    BrowserAnimationsModule,
    FormsModule,
    CommonModule,
    HttpClientModule,
    ThemeModule,
    NgbModule,
    RouterModule,
    AppRoutingModule,
    ToastrModule.forRoot(),
    MatDialogModule
  ],
  declarations: [AppComponent,
    DashboardPage,
    PregledPage,
    LokacijskaDozvolaComponent,
    ConfirmDialog,
    EditLokacijskaDozvolaDialog,
    AddLokacijskaDozvolaDialog
  ],
  providers: [],
  bootstrap: [AppComponent],
  entryComponents: [
    ConfirmDialog,
    EditLokacijskaDozvolaDialog,
    AddLokacijskaDozvolaDialog
  ]
})
export class AppModule { }
