import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ServiceResult } from '../models/service-result.model';
import { ProjekatZaGradjevinskuDozvolu } from '../models/projekat-za-gradjevinsku-dozvolu.model';
import { IdejnoResenjeService } from './idejno-resenje.service';
import { GlavniProjektantService } from './glavni-projektant.service';

const httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Response-Type': 'text' })
};

@Injectable({
    providedIn: 'root'
})

export class ProjekatZaGradjevinskuDozvoluService {

    url = 'https://localhost:44306/api/projektiZaGradjevinskuDozvolu/';

    constructor(
        private http: HttpClient,
        private idejnoResenjeService: IdejnoResenjeService,
        private glavniProjektantService: GlavniProjektantService
    ) { }

    getAll(): Observable<ProjekatZaGradjevinskuDozvolu[]> {
        return this.http.get<ProjekatZaGradjevinskuDozvolu[]>(this.url);
    }

    getById(id: number): Observable<ProjekatZaGradjevinskuDozvolu> {
        return this.http.get<ProjekatZaGradjevinskuDozvolu>(this.url + `${id}`);
    }

    add(projekatZaGradjevinskuDozvolu: ProjekatZaGradjevinskuDozvolu): Observable<ServiceResult> {
        return this.http.post<ServiceResult>(this.url, projekatZaGradjevinskuDozvolu, httpOptions);
    }

    update(projekatZaGradjevinskuDozvolu: ProjekatZaGradjevinskuDozvolu, id: number): Observable<ServiceResult> {
        return this.http.put<ServiceResult>(this.url + `${id}`, projekatZaGradjevinskuDozvolu, httpOptions);
    }

    delete(id: number): Observable<ServiceResult> {
        return this.http.delete<ServiceResult>(this.url + `${id}`, httpOptions);
    }
}
