import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { RouterModule } from "@angular/router";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";

import { FooterComponent } from "./footer/footer.component";
import { NavbarComponent } from "./navbar/navbar.component";
import { OperatorSidebarComponent } from "./operator-sidebar/operator-sidebar.component";
import { AdminSidebarComponent } from "./admin-sidebar/admin-sidebar.component";

@NgModule({
  imports: [CommonModule, RouterModule, NgbModule],
  declarations: [FooterComponent, NavbarComponent, OperatorSidebarComponent, AdminSidebarComponent ],
  exports: [FooterComponent, NavbarComponent, OperatorSidebarComponent, AdminSidebarComponent]
})
export class ComponentsModule {}
