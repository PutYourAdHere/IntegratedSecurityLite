import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { RouterModule } from "@angular/router";
import { CommonModule } from "@angular/common";
import { FormsModule } from "@angular/forms";

import { OperatorLayoutRoutes } from "./operator-layout.routing";
// import { DashboardComponent } from "../../pages/dashboard/dashboard.component";
// import { MapComponent } from "../../pages/map/map.component";
// import { NotificationsComponent } from "../../pages/notifications/notifications.component";
// import { UserComponent } from "../../pages/user/user.component";
// import { TablesComponent } from "../../pages/tables/tables.component";

import { NgbModule } from "@ng-bootstrap/ng-bootstrap";

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(OperatorLayoutRoutes),
    FormsModule,
    HttpClientModule,
    NgbModule,
  ],
  // declarations: [
  //   DashboardComponent,
  //   UserComponent,
  //   TablesComponent,
  //   NotificationsComponent,
  //   MapComponent,
  // ]
})
export class OperatorLayoutModule {}
