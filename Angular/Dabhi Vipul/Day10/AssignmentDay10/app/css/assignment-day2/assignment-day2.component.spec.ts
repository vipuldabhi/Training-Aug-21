import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AssignmentDay2Component } from './assignment-day2.component';

describe('AssignmentDay2Component', () => {
  let component: AssignmentDay2Component;
  let fixture: ComponentFixture<AssignmentDay2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AssignmentDay2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AssignmentDay2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
