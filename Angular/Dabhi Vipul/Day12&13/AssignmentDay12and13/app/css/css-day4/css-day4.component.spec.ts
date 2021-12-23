import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CssDay4Component } from './css-day4.component';

describe('CssDay4Component', () => {
  let component: CssDay4Component;
  let fixture: ComponentFixture<CssDay4Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CssDay4Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CssDay4Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
