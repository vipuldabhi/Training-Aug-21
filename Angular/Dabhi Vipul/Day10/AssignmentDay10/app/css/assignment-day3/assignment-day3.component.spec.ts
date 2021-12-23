import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AssignmentDay3Component } from './assignment-day3.component';

describe('AssignmentDay3Component', () => {
  let component: AssignmentDay3Component;
  let fixture: ComponentFixture<AssignmentDay3Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AssignmentDay3Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AssignmentDay3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
