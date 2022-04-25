import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddBookFormComponent } from './add-book-form/add-book-form.component';
import { BookListComponent } from './book-list/book-list.component';

const routes: Routes = [
  { path: "", component: BookListComponent },
  { path: "add", component: AddBookFormComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
