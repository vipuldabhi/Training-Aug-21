import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CssDay1Component } from './css-day1.component';

describe('CssDay1Component', () => {
  let component: CssDay1Component;
  let fixture: ComponentFixture<CssDay1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CssDay1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CssDay1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
