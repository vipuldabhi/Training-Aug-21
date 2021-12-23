import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AsignmentDay1Component } from './asignment-day1.component';

describe('AsignmentDay1Component', () => {
  let component: AsignmentDay1Component;
  let fixture: ComponentFixture<AsignmentDay1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AsignmentDay1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AsignmentDay1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
