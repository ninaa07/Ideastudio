import { LokacijskaDozvola } from './lokacijska-dozvola.model';
import { Objekat } from './objekat.model';
import { GlavniProjektant } from './glavni-projektant.model';
import { ProjekatZaGradjevinskuDozvolu } from './projekat-za-gradjevinsku-dozvolu.model';

export class IdejnoResenje {

    id: number;

    naziv: string;

    datumIzrade: Date;

    glavniProjektantId: number;

    objekatId: number;

    lokacijskaDozvolaId: number;

    projektiZaGradjevinskuDozvolu: ProjekatZaGradjevinskuDozvolu;
}