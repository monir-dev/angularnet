
import { NgModule } from '@angular/core';
import { CommonModule } from "@angular/common";
import { RouterModule, Routes } from "@angular/router";
import { ReactiveFormsModule, FormsModule } from "@angular/forms";


import { StoreModule } from "@ngrx/store";

import { CustomerComponent } from "./customer/customer.component";
import { CustomerAddComponent } from "./customer-add/customer-add.component";
import { CustomerEditComponent } from "./customer-edit/customer-edit.component";
import { CustomerlistComponent } from "./customer-list/customer-list.component";

import { UploadComponent } from "../upload/upload.component";

const customerRoutes: Routes = [
  { path: "", component: CustomerComponent },
  { path: "customers/create", component: CustomerAddComponent },
  { path: "customers/update", component: CustomerEditComponent },
  { path: "customers/list", component: CustomerlistComponent },
];

@NgModule({
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule.forChild(customerRoutes),
    //StoreModule.forFeature("customers", customerReducer),
    //EffectsModule.forFeature([CustomerEffect])
  ],

 declarations: [
    CustomerlistComponent,
    CustomerComponent,
    CustomerAddComponent,
    CustomerEditComponent
  ]
})
export class CustomersModule {}
