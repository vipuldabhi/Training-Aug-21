import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Practiceday3Component } from './practiceday3.component';

describe('Practiceday3Component', () => {
  let component: Practiceday3Component;
  let fixture: ComponentFixture<Practiceday3Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Practiceday3Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Practiceday3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
