import { TestBed } from '@angular/core/testing';

import { AdminHubService } from './admin-hub.service';

describe('AdminHubService', () => {
  let service: AdminHubService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AdminHubService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
