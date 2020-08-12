import { MatDialogModule } from '@angular/material/dialog';
import { MatInputModule } from '@angular/material/input';
import { BrowserModule, Title } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import {MatToolbarModule} from '@angular/material/toolbar';
import {MatButtonModule} from '@angular/material/button';
import {MatTableModule} from '@angular/material/table';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ReactiveFormsModule } from '@angular/forms';
import { MatIconModule } from '@angular/material/icon';
import { HomeModule } from './home/home.module';
import { EndpointModule } from './endpoint/endpoint.module';

import { NavbarComponent } from './navbar/navbar.component';
import { AngularHelpComponent } from './angular-help/angular-help.component';
import { EndpointDataService } from './endpoint/endpoint-data.service';
import { HttpClientModule } from '@angular/common/http';
import { ModalDialogComponent } from './modal-dialog/modal-dialog.component';

@NgModule({
  declarations: [
    AppComponent,
    AngularHelpComponent,
    ModalDialogComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatToolbarModule,
    MatButtonModule,
    MatTableModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatIconModule,
    MatInputModule,
    HomeModule,
    EndpointModule,
    HttpClientModule,
    MatDialogModule,
    ReactiveFormsModule
  ],
  entryComponents: [ModalDialogComponent],
  providers: [Title, EndpointDataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
