import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JavascriptDay2Component } from './javascript-day2.component';

describe('JavascriptDay2Component', () => {
  let component: JavascriptDay2Component;
  let fixture: ComponentFixture<JavascriptDay2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JavascriptDay2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(JavascriptDay2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
