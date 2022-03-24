import { Component, OnInit } from '@angular/core';
import { MachineLocation } from 'src/app/models/machineLocation';
import { MachineService } from 'src/app/services/machine.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  machineAllLocations : MachineLocation[] = [];

  constructor(private machineService: MachineService) { }

  async ngOnInit(): Promise<void> {
    this.machineAllLocations = await this.machineService.getMachineAllLocation();
  }

}
