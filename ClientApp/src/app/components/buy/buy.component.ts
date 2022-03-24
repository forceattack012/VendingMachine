import { Component, Input, OnInit } from '@angular/core';
import { MachineInventory } from 'src/app/models/machineInventory';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-buy',
  templateUrl: './buy.component.html',
  styleUrls: ['./buy.component.css']
})
export class BuyComponent implements OnInit {

  isOpen: boolean = false;
  @Input() inventory = new MachineInventory();

  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.productService.isOpen.subscribe(open => this.isOpen = open);
  }

  buyItem(){
    this.productService.isOpen.emit(false);
    console.log(this.inventory);
  }

}
