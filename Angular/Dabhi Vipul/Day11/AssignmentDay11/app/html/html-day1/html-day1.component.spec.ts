import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HtmlDay1Component } from './html-day1.component';

describe('HtmlDay1Component', () => {
  let component: HtmlDay1Component;
  let fixture: ComponentFixture<HtmlDay1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HtmlDay1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HtmlDay1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
