import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MachineService {

  constructor(private httpClient: HttpClient) { }


}
