import { MachineInventory } from 'src/app/models/machineInventory';
import { EventEmitter, Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  isOpen: EventEmitter<any> = new EventEmitter(false);
  baseUrl: string = '';

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  async getInventories(): Promise<MachineInventory[]> {
    return this.httpClient.get<MachineInventory[]>(`/api/MachineInventory/`).toPromise();
  }

  async getInventoryByMachineId(machineId: string): Promise<MachineInventory[]> {
    return this.httpClient.get<MachineInventory[]>(`/api/MachineInventory/${machineId}`).toPromise();
  }


}
