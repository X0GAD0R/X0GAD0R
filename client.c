#include<stdio.h>
typedef struct client 
{
    /* data */
    char name[10] ;
    char familyName[10]  ;
    char adr[10] ;
    int Num_Compt ;
    int sold; 
}Client;



int main(){
    int nc , sta,i;
    float moy ;
    printf("entrez le nbr de client ");
    scanf("%d",&nc);
    Client mes_client[nc];
    sta=0;
    for(i=0;i<nc;i++){
    printf("entrez le nom de %d client ",i+1);
    scanf("%s",mes_client[i].name);
    printf("entrez le prenom de %d client ",i+1);
    scanf("%s",mes_client[i].familyName);
    ;printf("entrez le adresse de %d client ",i+1);
    scanf("%s",mes_client[i].adr);
    printf("entrez le numbre compte de %d client ",i+1);
    scanf("%d",&mes_client[i].Num_Compt);
    printf("entrez le solde de %d client ",i+1);
    scanf("%d",&mes_client[i].sold);
    
    sta=sta+mes_client[i].sold;
    }
    moy=1;
    moy=sta/nc;
    printf("la moyenne de solde = %.0f",moy);

}