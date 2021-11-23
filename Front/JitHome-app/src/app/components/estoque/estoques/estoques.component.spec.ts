/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { EstoquesComponent } from './estoques.component';

describe('EstoquesComponent', () => {
  let component: EstoquesComponent;
  let fixture: ComponentFixture<EstoquesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EstoquesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EstoquesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
