import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home.component';
import { CreateComponent } from './create/create.component';
import { UploadComponent } from './upload/upload.component';

import { DataService } from './_services/data.service';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { AlertifyService } from './_services/alertify.service';
import { UpdateComponent } from './update/update.component';




@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      HomeComponent,
      CreateComponent,
      UpdateComponent,
      UploadComponent
   ],
   imports: [
      BrowserModule,
      FormsModule,
      HttpClientModule,
      RouterModule.forRoot([
        { path: '', component: HomeComponent },
        { path: 'create', component: CreateComponent },
        { path: 'edit/:id', component: UpdateComponent },
      ])
   ],
   providers: [
      DataService,
      AlertifyService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
