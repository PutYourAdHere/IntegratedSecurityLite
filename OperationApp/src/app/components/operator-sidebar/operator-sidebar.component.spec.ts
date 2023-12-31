import { async, ComponentFixture, TestBed } from "@angular/core/testing";

import { OperatorSidebarComponent } from "./operator-sidebar.component";

describe("OperatorSidebarComponent", () => {
  let component: OperatorSidebarComponent;
  let fixture: ComponentFixture<OperatorSidebarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [OperatorSidebarComponent]
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OperatorSidebarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it("should create", () => {
    expect(component).toBeTruthy();
  });
});
