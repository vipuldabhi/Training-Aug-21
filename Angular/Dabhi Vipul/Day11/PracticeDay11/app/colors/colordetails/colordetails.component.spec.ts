import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ColordetailsComponent } from './colordetails.component';

describe('ColordetailsComponent', () => {
  let component: ColordetailsComponent;
  let fixture: ComponentFixture<ColordetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ColordetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ColordetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
