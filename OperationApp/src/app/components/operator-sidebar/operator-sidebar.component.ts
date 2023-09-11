import { Component, OnInit } from "@angular/core";

declare interface RouteInfo {
  path: string;
  title: string;
  icon: string;
  class: string;
}
export const ROUTES: RouteInfo[] = [
  {
    path: "/operate/dashboard",
    title: "Dashboard",
    icon: "icon-chart-pie-36",
    class: ""
  },
  {
    path: "/operate/maps",
    title: "Maps",
    icon: "icon-pin",
    class: "" },
  {
    path: "/operate/notifications",
    title: "Notifications",
    icon: "icon-bell-55",
    class: ""
  },

  {
    path: "/operate/user",
    title: "User Profile",
    icon: "icon-single-02",
    class: ""
  },
  {
    path: "/operate/tables",
    title: "Table List",
    icon: "icon-puzzle-10",
    class: ""
  }
];

@Component({
  selector: "app-operator-sidebar",
  templateUrl: "./operator-sidebar.component.html",
  styleUrls: ["./operator-sidebar.component.scss"]
})
export class OperatorSidebarComponent implements OnInit {
  menuItems: any[];

  constructor() {}

  ngOnInit() {
    this.menuItems = ROUTES.filter(menuItem => menuItem);
  }
  isMobileMenu() {
    if (window.innerWidth > 991) {
      return false;
    }
    return true;
  }
}
