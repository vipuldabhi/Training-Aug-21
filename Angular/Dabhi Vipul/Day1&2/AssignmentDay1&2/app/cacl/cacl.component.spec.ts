import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CaclComponent } from './cacl.component';

describe('CaclComponent', () => {
  let component: CaclComponent;
  let fixture: ComponentFixture<CaclComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CaclComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CaclComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
