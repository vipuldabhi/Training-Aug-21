import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ColorsdetailsComponent } from './colorsdetails.component';

describe('ColorsdetailsComponent', () => {
  let component: ColorsdetailsComponent;
  let fixture: ComponentFixture<ColorsdetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ColorsdetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ColorsdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
