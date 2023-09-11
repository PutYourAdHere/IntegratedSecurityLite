import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { BrowserModule } from "@angular/platform-browser";
import { Routes, RouterModule } from "@angular/router";

import { AdminLayoutComponent } from "./layouts/admin-layout/admin-layout.component";
import { OperatorLayoutComponent } from "./layouts/operator-layout/operator-layout.component";

const routes: Routes = [
  //default
  {
    path: "",
    redirectTo: "operate/dashboard",
    pathMatch: "full"
  },
  //admin
  {
    path: "admin",
    redirectTo: "admin/dashboard",
    pathMatch: "full"
  },
  {
    path: "",
    component: AdminLayoutComponent,
    children: [
      {
        path: "admin",
        loadChildren: () => import('./layouts/admin-layout/admin-layout.module').then(m => m.AdminLayoutModule)
      }
    ]
  }, 
  //operate
  {
    path: "operate",
    redirectTo: "operate/dashboard",
    pathMatch: "full"
  },
  {
    path: "",
    component: OperatorLayoutComponent,
    children: [
      {
        path: "operate",
        loadChildren: () => import('./layouts/operator-layout/operator-layout.module').then(m => m.OperatorLayoutModule)
      }
    ]
  },
  //others
  {
    path: "**",
    redirectTo: "operate/dashboard"
  }
];

@NgModule({
  imports: [
    CommonModule,
    BrowserModule,
    RouterModule.forRoot(routes, {
      useHash: true
    })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}
