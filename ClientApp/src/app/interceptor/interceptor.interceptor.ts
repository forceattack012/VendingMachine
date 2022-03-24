import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { AuthenService } from '../services/authen.service';
import { tap } from "rxjs/operators";

@Injectable()
export class Interceptor implements HttpInterceptor {

  constructor(private router: Router, private authenService: AuthenService) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<any>> {
    const token = localStorage.getItem('token');

    if(token !== null && this.authenService.isAuthenticated()){
      request = request.clone({
        setHeaders: {
          'Content-Type': 'application/json',
           Authorization: 'Bearer ' +token
        }
      })
    }
    return next.handle(request).pipe(tap(() => {},
      (err:any) => {
        if (err instanceof HttpErrorResponse) {
          if (err.status !== 401) {
            return;
           }
           this.router.navigate(['login']);
        }
      }
    ));
  }
}

