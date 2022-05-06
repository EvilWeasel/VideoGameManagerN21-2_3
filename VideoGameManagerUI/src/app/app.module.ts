import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';

// AppModule is the root module of the application.
// To work with the Http-Client, to retrieve data from the ASP.NET-WebAPI,
// the HttpClientModule must be imported.

// The HttpClientModule must be added to the imports array of the AppModule.
@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
