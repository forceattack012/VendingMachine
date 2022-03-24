import { Component, OnInit, Output } from '@angular/core';
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

  constructor(private productService: ProductService) { }

  async ngOnInit(): Promise<void> {
    this.inventories = await this.productService.getInventories();
    console.log(this.inventories);
  }

  openSizebar(item: MachineInventory) {
    this.productService.isOpen.emit(!this.isOpen);
    this.product = item;
  }

}
