
import {RouterModule, Routes} from '@angular/router';
import {ClasseComponent} from './time-table/classe/classe.component';
import {DisplayClasseComponent} from './classe/display/display.classe.component';
import {ListClasseComponent} from './classe/list/list.classe.component';

const routes: Routes = [
  { path: 'times/:id/display', component: ClasseComponent },
  { path: 'classes/:id/display', component: DisplayClasseComponent },
  { path: 'times/list', component: ListClasseComponent },
  { path: '', redirectTo: 'times/list', pathMatch: 'full' }

];
export const routing = RouterModule.forRoot(routes);
