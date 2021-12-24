import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Practiceday1and2Component } from './practiceday1and2.component';

describe('Practiceday1and2Component', () => {
  let component: Practiceday1and2Component;
  let fixture: ComponentFixture<Practiceday1and2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Practiceday1and2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Practiceday1and2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
