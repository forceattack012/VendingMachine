import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MachineLocation } from '../models/machineLocation';

@Injectable({
  providedIn: 'root'
})
export class MachineService {

  constructor(private httpClient: HttpClient) { }

  async getMachineAllLocation(): Promise<MachineLocation[]> {
    return await this.httpClient.get<MachineLocation[]>('/api/Machine').toPromise();
  }
}
