import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AssignmentDay1Component } from './assignment-day1.component';

describe('AssignmentDay1Component', () => {
  let component: AssignmentDay1Component;
  let fixture: ComponentFixture<AssignmentDay1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AssignmentDay1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AssignmentDay1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
