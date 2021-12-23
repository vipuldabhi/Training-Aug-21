import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JavascriptDay4Component } from './javascript-day4.component';

describe('JavascriptDay4Component', () => {
  let component: JavascriptDay4Component;
  let fixture: ComponentFixture<JavascriptDay4Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JavascriptDay4Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(JavascriptDay4Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
