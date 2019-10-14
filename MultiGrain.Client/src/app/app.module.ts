import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';

import { AppRoutingModule, routingComponent} from './app-routing.module';
import { UploadsComponent } from './uploads/uploads.component';
import { FileUploadService } from './upload_service/file-upload.service';

import { InstitutionsComponent } from './institutions/institutions.component';
import { InstitutionComponent} from './institutions/institution/institution.component';
import { InstitutionListComponent } from './institutions/institution-list/institution-list.component';
import { InstitutionService } from './shared/shared-institutions/institution.service';

import { PersonsComponent } from './persons/persons.component';
import { PersonComponent } from './persons/person/person.component';
import { PersonListComponent } from './persons/person-list/person-list.component';
import { PersonsService } from './shared/shared-persons/persons.service';
import { UniquePipe } from './filter';



@NgModule({
  declarations: [
    AppComponent,
    routingComponent,
    UploadsComponent,
    InstitutionsComponent,
    InstitutionComponent,
    InstitutionListComponent,
    PersonsComponent,
    PersonComponent,
    PersonListComponent,
    UniquePipe
  
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    ReactiveFormsModule,
    ToastrModule.forRoot()
  ],
  providers: [FileUploadService,InstitutionService,PersonsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
