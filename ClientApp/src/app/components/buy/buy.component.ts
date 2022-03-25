import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import {  Router } from '@angular/router';
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
  cartItemForm: any;
  total: Number = 0.0;
  selectedValue = 1;

  Quality : Number[] = [];

  constructor(private productService: ProductService, private formBuilder: FormBuilder, private route: Router) { }

  ngOnInit(): void {
    this.productService.isOpen.subscribe(open => this.isOpen = open);
  }

  ngOnChanges(){
    this.cartItemForm = this.formBuilder.group({
      id : [this.inventory.inventoryId],
      productId: [this.inventory.productId],
      quality: [1],
      price: [this.inventory.price]
    });
    this.total = this.cartItemForm.get('price').value * this.quality.value;
    this.Quality = Array.from({length: this.inventory.quatity}, (_, index) => index + 1);
  }

  get quality() {
    return this.cartItemForm.get('quality');
  }

  changeQuality(value: any){
    this.cartItemForm.controls['quality'].setValue(value);
    this.total = this.cartItemForm.get('price').value * value;
  }

  async buyItem(){
    if(this.cartItemForm.valid){
      await this.productService.buy(this.cartItemForm.value);
      this.productService.isOpen.emit(false);

    }
  }

}
