import { MachineInventory } from 'src/app/models/machineInventory';
import { EventEmitter, Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  isOpen: EventEmitter<any> = new EventEmitter(false);
  baseUrl: string = '';

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string, private route: Router) {
    this.baseUrl = baseUrl;
  }

  async getInventories(): Promise<MachineInventory[]> {
    return this.httpClient.get<MachineInventory[]>(`/api/MachineInventory/`).toPromise();
  }

  async getInventoryByMachineId(machineId: string): Promise<MachineInventory[]> {
    return this.httpClient.get<MachineInventory[]>(`/api/MachineInventory/${machineId}`).toPromise();
  }

  async buy(cartItem: any) {
    const x = await this.httpClient.post(`/api/MachineInventory/buy`, cartItem).toPromise();
    this.route.navigate(['/product']);
  }


}
