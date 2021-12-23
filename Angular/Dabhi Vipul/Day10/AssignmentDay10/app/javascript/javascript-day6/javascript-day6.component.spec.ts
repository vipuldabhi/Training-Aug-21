import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JavascriptDay6Component } from './javascript-day6.component';

describe('JavascriptDay6Component', () => {
  let component: JavascriptDay6Component;
  let fixture: ComponentFixture<JavascriptDay6Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JavascriptDay6Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(JavascriptDay6Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
