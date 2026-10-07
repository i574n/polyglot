#include <stdbool.h>
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
typedef struct {
    int refc;
    uint32_t len;
    double ptr[];
} Array0;
typedef struct {
    int refc;
    int32_t v0;
} Mut0;
typedef struct {
    int refc;
    uint32_t len;
    int32_t ptr[];
} Array1;
typedef struct {
    int refc;
    double v0;
    double v1;
    double v2;
} Mut1;
typedef struct {
    int refc;
    int32_t v0;
} Mut2;
typedef struct {
    int refc;
    double v0;
} Mut3;
typedef struct {
    int refc;
    uint32_t len;
    char ptr[];
} Array2;
typedef Array2 String;
static inline void ArrayDecrefBody0(Array0 * x){
}
void ArrayDecref0(Array0 * x){
    if (x != NULL && --(x->refc) == 0) { ArrayDecrefBody0(x); free(x); }
}
Array0 * ArrayCreate0(uint32_t len, bool init_at_zero){
    uint32_t size = sizeof(Array0) + sizeof(double) * len;
    Array0 * x = malloc(size);
    if (init_at_zero) { memset(x,0,size); }
    x->refc = 1;
    x->len = len;
    return x;
}
Array0 * ArrayLit0(uint32_t len, double * ptr){
    Array0 * x = ArrayCreate0(len, false);
    memcpy(x->ptr, ptr, sizeof(double) * len);
    return x;
}
static inline void MutDecrefBody0(Mut0 * x){
    
}
void MutDecref0(Mut0 * x){
    if (x != NULL && --(x->refc) == 0) { MutDecrefBody0(x); free(x); }
}
Mut0 * MutCreate0(int32_t v0){
    Mut0 * x = malloc(sizeof(Mut0));
    x->refc = 1;
    x->v0 = v0;
    return x;
}
bool method_while0(Mut0 * v0){
    
    
    int32_t v1;
    v1 = v0->v0;
    
    
    bool v2;
    v2 = v1 < 7040l;
    
    
    return v2;
}
static inline void AssignArray0(double * a, double b){
    
    
    *a = b;
}
static inline void AssignMut0(int32_t * a0, int32_t b0){
    
    
    *a0 = b0;
}
static inline void ArrayDecrefBody1(Array1 * x){
}
void ArrayDecref1(Array1 * x){
    if (x != NULL && --(x->refc) == 0) { ArrayDecrefBody1(x); free(x); }
}
Array1 * ArrayCreate1(uint32_t len, bool init_at_zero){
    uint32_t size = sizeof(Array1) + sizeof(int32_t) * len;
    Array1 * x = malloc(size);
    if (init_at_zero) { memset(x,0,size); }
    x->refc = 1;
    x->len = len;
    return x;
}
Array1 * ArrayLit1(uint32_t len, int32_t * ptr){
    Array1 * x = ArrayCreate1(len, false);
    memcpy(x->ptr, ptr, sizeof(int32_t) * len);
    return x;
}
static inline void AssignArray1(int32_t * a, int32_t b){
    
    
    *a = b;
}
static inline void MutDecrefBody1(Mut1 * x){
    
}
void MutDecref1(Mut1 * x){
    if (x != NULL && --(x->refc) == 0) { MutDecrefBody1(x); free(x); }
}
Mut1 * MutCreate1(double v0, double v1, double v2){
    Mut1 * x = malloc(sizeof(Mut1));
    x->refc = 1;
    x->v0 = v0; x->v1 = v1; x->v2 = v2;
    return x;
}
static inline void MutDecrefBody2(Mut2 * x){
    
}
void MutDecref2(Mut2 * x){
    if (x != NULL && --(x->refc) == 0) { MutDecrefBody2(x); free(x); }
}
Mut2 * MutCreate2(int32_t v0){
    Mut2 * x = malloc(sizeof(Mut2));
    x->refc = 1;
    x->v0 = v0;
    return x;
}
bool method_while1(Mut0 * v0){
    
    
    int32_t v1;
    v1 = v0->v0;
    
    
    bool v2;
    v2 = v1 < 60l;
    
    
    return v2;
}
static inline void MutDecrefBody3(Mut3 * x){
    
}
void MutDecref3(Mut3 * x){
    if (x != NULL && --(x->refc) == 0) { MutDecrefBody3(x); free(x); }
}
Mut3 * MutCreate3(double v0){
    Mut3 * x = malloc(sizeof(Mut3));
    x->refc = 1;
    x->v0 = v0;
    return x;
}
bool method_while2(double v0, Mut3 * v1){
    
    
    double v2;
    v2 = v1->v0;
    
    
    bool v3;
    v3 = v2 < v0;
    
    
    return v3;
}
bool method_while3(double v0, Mut3 * v1){
    
    
    double v2;
    v2 = v1->v0;
    
    
    bool v3;
    v3 = v2 < v0;
    
    
    return v3;
}
void plot2(Array0 * v0, Array1 * v1, double v2, double v3, double v4, double v5, double v6, double v7, double v8, int32_t v9){
    
    
    double v10;
    v10 = sin(v2);
    
    
    double v11;
    v11 = v7 * v10;
    
    
    double v12;
    v12 = sin(v3);
    
    
    double v13;
    v13 = v11 * v12;
    
    
    double v14;
    v14 = cos(v4);
    
    
    double v15;
    v15 = v13 * v14;
    
    
    double v16;
    v16 = cos(v2);
    
    
    double v17;
    v17 = v8 * v16;
    
    
    double v18;
    v18 = v17 * v12;
    
    
    double v19;
    v19 = v18 * v14;
    
    
    double v20;
    v20 = v15 - v19;
    
    
    double v21;
    v21 = v7 * v16;
    
    
    double v22;
    v22 = sin(v4);
    
    
    double v23;
    v23 = v21 * v22;
    
    
    double v24;
    v24 = v20 + v23;
    
    
    double v25;
    v25 = v8 * v10;
    
    
    double v26;
    v26 = v25 * v22;
    
    
    double v27;
    v27 = v24 + v26;
    
    
    double v28;
    v28 = cos(v3);
    
    
    double v29;
    v29 = v6 * v28;
    
    
    double v30;
    v30 = v29 * v14;
    
    
    double v31;
    v31 = v27 + v30;
    
    
    double v32;
    v32 = v21 * v14;
    
    
    double v33;
    v33 = v25 * v14;
    
    
    double v34;
    v34 = v32 + v33;
    
    
    double v35;
    v35 = v13 * v22;
    
    
    double v36;
    v36 = v34 - v35;
    
    
    double v37;
    v37 = v18 * v22;
    
    
    double v38;
    v38 = v36 + v37;
    
    
    double v39;
    v39 = v29 * v22;
    
    
    double v40;
    v40 = v38 - v39;
    
    
    double v41;
    v41 = v17 * v28;
    
    
    double v42;
    v42 = v11 * v28;
    
    
    double v43;
    v43 = v41 - v42;
    
    
    double v44;
    v44 = v6 * v12;
    
    
    double v45;
    v45 = v43 + v44;
    
    
    double v46;
    v46 = v45 + 100.0;
    
    
    double v47;
    v47 = 1.0 / v46;
    
    
    double v48;
    v48 = 80.0 + v5;
    
    
    double v49;
    v49 = 40.0 * v47;
    
    
    double v50;
    v50 = v49 * v31;
    
    
    double v51;
    v51 = v50 * 2.0;
    
    
    double v52;
    v52 = v48 + v51;
    
    
    int32_t v53;
    v53 = (int32_t)v52;
    
    
    double v54;
    v54 = v49 * v40;
    
    
    double v55;
    v55 = 22.0 + v54;
    
    
    int32_t v56;
    v56 = (int32_t)v55;
    
    
    int32_t v57;
    v57 = v56 * 160l;
    
    
    int32_t v58;
    v58 = v53 + v57;
    
    
    bool v59;
    v59 = v58 >= 0l;
    
    
    bool v61;
    if (v59){
        
        
        bool v60;
        v60 = v58 < 7040l;
        
        
        v61 = v60;
    } else {
        
        
        v61 = false;
    }
    
    
    if (v61){
        
        
        double v62;
        v62 = v0->ptr[v58];
        
        
        bool v63;
        v63 = v47 > v62;
        
        
        if (v63){
            
            
            
            AssignArray0(&(v0->ptr[v58]), v47);
            
            ArrayDecref0(v0);
            
            AssignArray1(&(v1->ptr[v58]), v9);
            
            ArrayDecref1(v1);
            return ;
        } else {
            
            ArrayDecref0(v0); ArrayDecref1(v1);
            return ;
        }
    } else {
        
        ArrayDecref0(v0); ArrayDecref1(v1);
        return ;
    }
}
static inline void AssignMut1(double * a0, double b0){
    
    
    *a0 = b0;
}
void draw_cube1(Array0 * v0, Array1 * v1, double v2, double v3, double v4, double v5, double v6){
    
    
    double v7;
    v7 = -v5;
    
    
    Mut3 * v8;
    v8 = MutCreate3(v7);
    
    
    
    while (method_while2(v5, v8)){
        
        
        Mut3 * v10;
        v10 = MutCreate3(v7);
        
        
        
        while (method_while3(v5, v10)){
            
            
            double v12;
            v12 = v8->v0;
            
            
            double v13;
            v13 = v10->v0;
            
            
            int32_t v14;
            v14 = 59l;
            v0->refc++; v1->refc++;
            
            
            plot2(v0, v1, v2, v3, v4, v6, v12, v13, v7, v14);
            
            
            int32_t v15;
            v15 = 92l;
            v0->refc++; v1->refc++;
            
            
            plot2(v0, v1, v2, v3, v4, v6, v5, v13, v12, v15);
            
            
            double v16;
            v16 = -v12;
            
            
            int32_t v17;
            v17 = 47l;
            v0->refc++; v1->refc++;
            
            
            plot2(v0, v1, v2, v3, v4, v6, v7, v13, v16, v17);
            
            
            int32_t v18;
            v18 = 61l;
            v0->refc++; v1->refc++;
            
            
            plot2(v0, v1, v2, v3, v4, v6, v16, v13, v5, v18);
            
            
            double v19;
            v19 = -v13;
            
            
            int32_t v20;
            v20 = 62l;
            v0->refc++; v1->refc++;
            
            
            plot2(v0, v1, v2, v3, v4, v6, v12, v7, v19, v20);
            
            
            int32_t v21;
            v21 = 60l;
            v0->refc++; v1->refc++;
            
            
            plot2(v0, v1, v2, v3, v4, v6, v12, v5, v13, v21);
            
            
            double v22;
            v22 = v10->v0;
            
            
            double v23;
            v23 = v22 + 0.6;
            
            
            
            AssignMut1(&(v10->v0), v23);
            
            
            
        }
        
        MutDecref3(v10);
        double v24;
        v24 = v8->v0;
        
        
        double v25;
        v25 = v24 + 0.6;
        
        
        
        AssignMut1(&(v8->v0), v25);
        
        
        
    }
    
    ArrayDecref0(v0); ArrayDecref1(v1); MutDecref3(v8);
    return ;
}
bool method_while4(Mut0 * v0){
    
    
    int32_t v1;
    v1 = v0->v0;
    
    
    bool v2;
    v2 = v1 < 44l;
    
    
    return v2;
}
bool method_while5(Mut0 * v0){
    
    
    int32_t v1;
    v1 = v0->v0;
    
    
    bool v2;
    v2 = v1 < 160l;
    
    
    return v2;
}
static inline void ArrayDecrefBody2(Array2 * x){
}
void ArrayDecref2(Array2 * x){
    if (x != NULL && --(x->refc) == 0) { ArrayDecrefBody2(x); free(x); }
}
Array2 * ArrayCreate2(uint32_t len, bool init_at_zero){
    uint32_t size = sizeof(Array2) + sizeof(char) * len;
    Array2 * x = malloc(size);
    if (init_at_zero) { memset(x,0,size); }
    x->refc = 1;
    x->len = len;
    return x;
}
Array2 * ArrayLit2(uint32_t len, char * ptr){
    Array2 * x = ArrayCreate2(len, false);
    memcpy(x->ptr, ptr, sizeof(char) * len);
    return x;
}
static inline void StringDecref(String * x){
    return ArrayDecref2(x);
}
static inline String * StringLit(uint32_t len, char * ptr){
    return ArrayLit2(len, ptr);
}
int32_t render0(Array0 * v0, Array1 * v1, double v2, double v3, double v4, int32_t v5){
    
    
    Mut0 * v6;
    v6 = MutCreate0(0l);
    
    
    
    while (method_while0(v6)){
        
        
        int32_t v8;
        v8 = v6->v0;
        
        
        
        
        
        
        
        AssignArray0(&(v0->ptr[v8]), 0.0);
        
        
        
        AssignArray1(&(v1->ptr[v8]), 46l);
        
        
        int32_t v9;
        v9 = v8 + 1l;
        
        
        
        AssignMut0(&(v6->v0), v9);
        
        
        
    }
    
    
    
    
    
    MutDecref0(v6);
    double v10;
    v10 = 20.0;
    
    
    double v11;
    v11 = -40.0;
    v0->refc++; v1->refc++;
    
    
    draw_cube1(v0, v1, v2, v3, v4, v10, v11);
    
    
    double v12;
    v12 = 10.0;
    
    
    double v13;
    v13 = 10.0;
    v0->refc++; v1->refc++;
    
    
    draw_cube1(v0, v1, v2, v3, v4, v12, v13);
    
    
    double v14;
    v14 = 5.0;
    
    
    double v15;
    v15 = 40.0;
    v0->refc++; v1->refc++;
    
    
    draw_cube1(v0, v1, v2, v3, v4, v14, v15);
    
    ArrayDecref0(v0);
    
    printf("%s", "u001b[H");
    
    
    Mut2 * v19;
    v19 = MutCreate2(v5);
    
    
    Mut0 * v20;
    v20 = MutCreate0(0l);
    
    
    
    while (method_while4(v20)){
        
        
        int32_t v22;
        v22 = v20->v0;
        
        
        
        
        
        
        Mut0 * v23;
        v23 = MutCreate0(0l);
        
        
        
        while (method_while5(v23)){
            
            
            int32_t v25;
            v25 = v23->v0;
            
            
            
            
            
            
            int32_t v26;
            v26 = v22 * 160l;
            
            
            int32_t v27;
            v27 = v25 + v26;
            
            
            int32_t v28;
            v28 = v1->ptr[v27];
            
            
            bool v29;
            v29 = v28 == 59l;
            
            
            String * v47;
            if (v29){
                
                
                String * v30;
                v30 = StringLit(2, ";");
                
                
                v47 = v30;
            } else {
                
                
                bool v31;
                v31 = v28 == 92l;
                
                
                if (v31){
                    
                    
                    String * v32;
                    v32 = StringLit(2, "\\");
                    
                    
                    v47 = v32;
                } else {
                    
                    
                    bool v33;
                    v33 = v28 == 47l;
                    
                    
                    if (v33){
                        
                        
                        String * v34;
                        v34 = StringLit(2, "/");
                        
                        
                        v47 = v34;
                    } else {
                        
                        
                        bool v35;
                        v35 = v28 == 61l;
                        
                        
                        if (v35){
                            
                            
                            String * v36;
                            v36 = StringLit(2, "=");
                            
                            
                            v47 = v36;
                        } else {
                            
                            
                            bool v37;
                            v37 = v28 == 62l;
                            
                            
                            if (v37){
                                
                                
                                String * v38;
                                v38 = StringLit(2, ">");
                                
                                
                                v47 = v38;
                            } else {
                                
                                
                                bool v39;
                                v39 = v28 == 60l;
                                
                                
                                if (v39){
                                    
                                    
                                    String * v40;
                                    v40 = StringLit(2, "<");
                                    
                                    
                                    v47 = v40;
                                } else {
                                    
                                    
                                    String * v41;
                                    v41 = StringLit(2, ".");
                                    
                                    
                                    v47 = v41;
                                }
                            }
                        }
                    }
                }
            }
            
            
            
            printf("%s", v47->ptr);
            
            StringDecref(v47);
            int32_t v48;
            v48 = v19->v0;
            
            
            int32_t v49;
            v49 = v48 * 31l;
            
            
            int32_t v50;
            v50 = v49 + v28;
            
            
            int32_t v51;
            v51 = v50 % 1000003l;
            
            
            
            AssignMut0(&(v19->v0), v51);
            
            
            int32_t v52;
            v52 = v25 + 1l;
            
            
            
            AssignMut0(&(v23->v0), v52);
            
            
            
        }
        
        
        
        
        
        MutDecref0(v23);
        
        printf("%s", "\n");
        
        
        int32_t v56;
        v56 = v22 + 1l;
        
        
        
        AssignMut0(&(v20->v0), v56);
        
        
        
    }
    
    ArrayDecref1(v1);
    
    
    
    MutDecref0(v20);
    int32_t v57;
    v57 = v19->v0;
    
    MutDecref2(v19);
    return v57;
}
static inline void AssignMut2(double * a0, double b0, double * a1, double b1, double * a2, double b2){
    
    
    *a0 = b0; *a1 = b1; *a2 = b2;
}
void print_digits3(int32_t v0){
    
    
    bool v1;
    v1 = v0 >= 10l;
    
    
    
    if (v1){
        
        
        int32_t v2;
        v2 = v0 / 10l;
        
        
        print_digits3(v2);
    } else {
        
        
        
    }
    
    
    int32_t v3;
    v3 = v0 % 10l;
    
    
    bool v4;
    v4 = v3 == 0l;
    
    
    String * v31;
    if (v4){
        
        
        String * v5;
        v5 = StringLit(2, "0");
        
        
        v31 = v5;
    } else {
        
        
        bool v6;
        v6 = v3 == 1l;
        
        
        if (v6){
            
            
            String * v7;
            v7 = StringLit(2, "1");
            
            
            v31 = v7;
        } else {
            
            
            bool v8;
            v8 = v3 == 2l;
            
            
            if (v8){
                
                
                String * v9;
                v9 = StringLit(2, "2");
                
                
                v31 = v9;
            } else {
                
                
                bool v10;
                v10 = v3 == 3l;
                
                
                if (v10){
                    
                    
                    String * v11;
                    v11 = StringLit(2, "3");
                    
                    
                    v31 = v11;
                } else {
                    
                    
                    bool v12;
                    v12 = v3 == 4l;
                    
                    
                    if (v12){
                        
                        
                        String * v13;
                        v13 = StringLit(2, "4");
                        
                        
                        v31 = v13;
                    } else {
                        
                        
                        bool v14;
                        v14 = v3 == 5l;
                        
                        
                        if (v14){
                            
                            
                            String * v15;
                            v15 = StringLit(2, "5");
                            
                            
                            v31 = v15;
                        } else {
                            
                            
                            bool v16;
                            v16 = v3 == 6l;
                            
                            
                            if (v16){
                                
                                
                                String * v17;
                                v17 = StringLit(2, "6");
                                
                                
                                v31 = v17;
                            } else {
                                
                                
                                bool v18;
                                v18 = v3 == 7l;
                                
                                
                                if (v18){
                                    
                                    
                                    String * v19;
                                    v19 = StringLit(2, "7");
                                    
                                    
                                    v31 = v19;
                                } else {
                                    
                                    
                                    bool v20;
                                    v20 = v3 == 8l;
                                    
                                    
                                    if (v20){
                                        
                                        
                                        String * v21;
                                        v21 = StringLit(2, "8");
                                        
                                        
                                        v31 = v21;
                                    } else {
                                        
                                        
                                        String * v22;
                                        v22 = StringLit(2, "9");
                                        
                                        
                                        v31 = v22;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    
    
    
    printf("%s", v31->ptr);
    
    StringDecref(v31);
    return ;
}
int32_t main(){
    
    
    Array0 * v0;
    v0 = ArrayCreate0(7040l, false);
    
    
    Mut0 * v1;
    v1 = MutCreate0(0l);
    
    
    
    while (method_while0(v1)){
        
        
        int32_t v3;
        v3 = v1->v0;
        
        
        
        
        
        
        
        AssignArray0(&(v0->ptr[v3]), 0.0);
        
        
        int32_t v4;
        v4 = v3 + 1l;
        
        
        
        AssignMut0(&(v1->v0), v4);
        
        
        
    }
    
    
    
    
    
    MutDecref0(v1);
    Array1 * v5;
    v5 = ArrayCreate1(7040l, false);
    
    
    Mut0 * v6;
    v6 = MutCreate0(0l);
    
    
    
    while (method_while0(v6)){
        
        
        int32_t v8;
        v8 = v6->v0;
        
        
        
        
        
        
        
        AssignArray1(&(v5->ptr[v8]), 46l);
        
        
        int32_t v9;
        v9 = v8 + 1l;
        
        
        
        AssignMut0(&(v6->v0), v9);
        
        
        
    }
    
    
    
    
    
    MutDecref0(v6);
    Mut1 * v10;
    v10 = MutCreate1(0.0, 0.0, 0.0);
    
    
    Mut2 * v11;
    v11 = MutCreate2(0l);
    
    
    Mut0 * v12;
    v12 = MutCreate0(0l);
    
    
    
    while (method_while1(v12)){
        
        
        int32_t v14;
        v14 = v12->v0;
        
        
        
        
        
        
        double v15; double v16; double v17;
        v15 = v10->v0; v16 = v10->v1; v17 = v10->v2;
        
        
        int32_t v18;
        v18 = v11->v0;
        v0->refc++; v5->refc++;
        
        int32_t v19;
        v19 = render0(v0, v5, v15, v16, v17, v18);
        
        
        
        AssignMut0(&(v11->v0), v19);
        
        
        double v20; double v21; double v22;
        v20 = v10->v0; v21 = v10->v1; v22 = v10->v2;
        
        
        double v23;
        v23 = v20 + 0.05;
        
        
        double v24;
        v24 = v21 + 0.05;
        
        
        double v25;
        v25 = v22 + 0.01;
        
        
        
        AssignMut2(&(v10->v0), v23, &(v10->v1), v24, &(v10->v2), v25);
        
        
        int32_t v26;
        v26 = v14 + 1l;
        
        
        
        AssignMut0(&(v12->v0), v26);
        
        
        
    }
    
    ArrayDecref0(v0); ArrayDecref1(v5); MutDecref1(v10);
    
    
    
    MutDecref0(v12);
    
    printf("%s", "cube: ");
    
    
    int32_t v30;
    v30 = 60l;
    
    
    
    print_digits3(v30);
    
    
    
    printf("%s", " frames, checksum ");
    
    
    int32_t v34;
    v34 = v11->v0;
    
    MutDecref2(v11);
    
    print_digits3(v34);
    
    
    
    printf("%s", "\n");
    
    
    return 0l;
}
