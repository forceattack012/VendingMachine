import { AuthenService } from 'src/app/services/authen.service';
import { Component, OnInit } from '@angular/core';
import { MachineInventory } from 'src/app/models/machineInventory'
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  isOpen = false;
  product = new MachineInventory();

  inventories : MachineInventory[] = [];

  constructor(private productService: ProductService, private authenService: AuthenService) { }

  async ngOnInit(): Promise<void> {
    this.inventories = await this.productService.getInventories();
  }

  openSizebar(item: MachineInventory) {
    this.productService.isOpen.emit(!this.isOpen);
    this.product = item;
  }

  IsBuy(): Boolean {
    return this.authenService.getUserRole() === '' || this.authenService.getUserRole() === 'User'
  }

}
