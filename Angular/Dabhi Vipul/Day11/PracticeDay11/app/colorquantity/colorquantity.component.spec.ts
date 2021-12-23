import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ColorquantityComponent } from './colorquantity.component';

describe('ColorquantityComponent', () => {
  let component: ColorquantityComponent;
  let fixture: ComponentFixture<ColorquantityComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ColorquantityComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ColorquantityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
