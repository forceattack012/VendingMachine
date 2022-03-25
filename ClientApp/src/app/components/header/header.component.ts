import { AdminHubService } from './../../services/admin-hub.service';
import { Component, OnInit } from '@angular/core';
import { AuthenService } from 'src/app/services/authen.service';
import { MachineInventory } from 'src/app/models/machineInventory';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  user: any;
  message: MachineInventory[] =[];

  
  constructor(private adminHubService: AdminHubService, private authenService: AuthenService) { }

  ngOnInit(): void {
    this.user = this.authenService.decodeToken();
    try{
      const hubConnection = this.adminHubService.startConnection();
      const x = hubConnection.invoke<string>('getConnectionId');
      hubConnection.on('notificationAdmin' , (result) => {
        const json = JSON.parse(result);
        this.message.push(json);
        this.message.length;
        console.log(this.message);
      });
    }
    catch(e){
      console.log("Error GetConnectionId ", e)
    }
  }

  isAdmin(): Boolean {
    return this.authenService.getUserRole() === "Admin";
  }

}
