import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PantallaBalanceComponent } from './pantalla-balance.component';

describe('PantallaBalanceComponent', () => {
  let component: PantallaBalanceComponent;
  let fixture: ComponentFixture<PantallaBalanceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PantallaBalanceComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PantallaBalanceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
