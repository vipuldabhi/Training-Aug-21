import { TestBed } from '@angular/core/testing';

import { HttpcruddemoService } from './httpcruddemo.service';

describe('HttpcruddemoService', () => {
  let service: HttpcruddemoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HttpcruddemoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
