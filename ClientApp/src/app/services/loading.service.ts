import { EventEmitter, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoadingService {

  isLoading: EventEmitter<any> = new EventEmitter(false);
  
  constructor() { }
}
