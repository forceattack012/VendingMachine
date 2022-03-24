import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthenService } from '../services/authen.service';
import decode from 'jwt-decode';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {

  constructor(private authenSerivce: AuthenService, private router: Router) {

  }

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {

      const expectedRole = route.data.expectedRole;
      const token = localStorage.getItem('token') ?? '';
      const tokenPayload = decode(token);
      console.log(tokenPayload);

      if(!this.authenSerivce.isAuthenticated() && !tokenPayload != expectedRole){
        this.router.navigate(['login']);
        return false;
      }

    return true;
  }

}