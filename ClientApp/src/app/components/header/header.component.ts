import { AdminHubService } from './../../services/admin-hub.service';
import { Component, OnInit } from '@angular/core';
import { AuthenService } from 'src/app/services/authen.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  user: any;
  message: any;

  constructor(private adminHubService: AdminHubService, private authenService: AuthenService) { }

  ngOnInit(): void {
    this.user = this.authenService.decodeToken();
    const hubConnection = this.adminHubService.startConnection();
    hubConnection.on('notificationAdmin' , (result) => {
      this.message = result;
      console.log(result);
    });
  }

  isAdmin(): Boolean {
    return this.authenService.getUserRole() === "Admin";
  }

}
