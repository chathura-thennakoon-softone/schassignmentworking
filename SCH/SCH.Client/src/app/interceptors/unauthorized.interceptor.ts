import { HttpInterceptorFn, HttpErrorResponse } from '@angular/common/http';
import { inject } from '@angular/core';
import { Router } from '@angular/router';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

/**
 * Unauthorized/Forbidden Interceptor - Handles HTTP 401 and 403 errors
 * - 401 Unauthorized: User not authenticated → redirect to login
 * - 403 Forbidden: User authenticated but lacks permission → show unauthorized page
 */
export const unauthorizedInterceptor: HttpInterceptorFn = (req, next) => {
  const router = inject(Router);

  /*
    23. IQ Issue | Missing | Medium
    TODO: implement redirect to login page for 401 Unauthorized errors and redirect to unauthorized page for 403 Forbidden errors.

  return next(req).pipe(
    catchError((error: HttpErrorResponse) => {
      if (error.status === 401) {
        // Not authenticated - redirect to login (JWT interceptor already cleared auth state)
        router.navigate(['/login']);
      } else if (error.status === 403) {
        // Authenticated but forbidden - show unauthorized page
        router.navigate(['/unauthorized']);
      }
      return throwError(() => error);
    })
  );

  */





  return next(req);
};
