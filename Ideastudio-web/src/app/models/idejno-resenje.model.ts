import { LokacijskaDozvola } from './lokacijska-dozvola.model';
import { Objekat } from './objekat.model';
import { GlavniProjektant } from './glavni-projektant.model';
import { ProjekatZaGradjevinskuDozvolu } from './projekat-za-gradjevinsku-dozvolu.model';

export class IdejnoResenje {

    id: number;

    naziv: string;

    datumIzrade: Date;

    glavniProjektant: GlavniProjektant;

    objekat: Objekat;

    lokacijskaDozvola: LokacijskaDozvola;

    projektiZaGradjevinskuDozvolu: ProjekatZaGradjevinskuDozvolu;
}