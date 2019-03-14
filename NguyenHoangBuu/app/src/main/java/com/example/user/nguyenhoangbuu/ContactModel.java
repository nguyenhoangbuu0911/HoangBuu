package com.example.user.nguyenhoangbuu;

import java.io.Serializable;

public class ContactModel implements Serializable {
    public String getTen() {
        return Ten;
    }

    public void setTen(String ten) {
        Ten = ten;
    }

    public String getMA() {
        return MA;
    }

    public void setMA(String MA) {
        this.MA = MA;
    }

    public int getGia() {
        return Gia;
    }

    public void setGia(int gia) {
        Gia = gia;
    }

    public ContactModel(String mTendt, String mMadt, int mGiadt){
        this.Gia = mGiadt;
        this.MA = mMadt;
        this.Ten = mTendt;

    }

    private String Ten;
    private String MA;
    private int Gia;
}