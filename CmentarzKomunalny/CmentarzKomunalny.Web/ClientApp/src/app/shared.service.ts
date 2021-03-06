import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIUrl = "https://localhost:44357/api"; /*Adres API - Adres po uruchomieniu przez .net*/

  constructor(private http: HttpClient) { }


  /* DANE O ROUTINGU W 'return ...' np: '/aktualnosci' wynikają z controlerów (np.[Route("api/aktualnosci")]) */

  /* AKTUALNOŚCI */

  /* METODA KONSUMUJĄCA DANE Z API */

  getAktualnosciList(): Observable<any[]> {
    return this.http.get<any>(this.APIUrl + "/news");
  }
  /* METODA DODAJĄCA DANE DO BAZY */
  addAktualnosci(val: any) {
    return this.http.post(this.APIUrl + '/news', val);
  }
  /* METODA AKTUALIZUJĄCA DANE DO BAZY */
  putAktualnosci(val: any) {
    return this.http.put(this.APIUrl + '/news', val);
  }
  /* METODA AKTUALIZUJĄCA DANE DO BAZY (usuwanie po ID aktualnosci)*/
  deleteAktualnosci(val: any) {
    return this.http.delete(this.APIUrl + '/news/' + val);
  }

  /* NEKROLOGI */

  /* METODA KONSUMUJĄCA DANE Z API */
  getNekrologiList(): Observable<any[]> {
    return this.http.get<any>(this.APIUrl + '/obituary');
  }
  /* METODA DODAJĄCA DANE DO BAZY */
  addNekrologi(val: any) {
    return this.http.post(this.APIUrl + '/obituary', val);
  }
  /* METODA AKTUALIZUJĄCA DANE DO BAZY */
  putNekrologi(val: any) {
    return this.http.put(this.APIUrl + '/obituary', val);
  }
  /* METODA AKTUALIZUJĄCA DANE DO BAZY (usuwanie po ID aktualnosci)*/
  deleteNekrologi(val: any) {
    return this.http.delete(this.APIUrl + '/obituary/' + val);
  }

  /* ZMARLI */

  getZmarliList(): Observable<any[]> {
    return this.http.get<any>(this.APIUrl + '/deadperson');
  }

  addDeadPerson(val: any) {
    return this.http.post(this.APIUrl + '/deadperson/', val);
  }

  putDeadPerson(val: any) {
    return this.http.put(this.APIUrl + '/deadperson/', val);
  }

  deleteDeadPerson(val: any) {
    return this.http.delete(this.APIUrl + '/deadperson/' + val);
  }
}
